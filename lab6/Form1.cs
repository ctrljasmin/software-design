using lab5;
using Microsoft.EntityFrameworkCore;
namespace lab6
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public async Task<List<string>> FetchBooksWithAuthorsAsync(IProgress<int> progress)
        {
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            return await Task.Run(() =>
            {
                using (var context = new BookstoreContext())
                {
                    var books = context.Books
                        .Include(book => book.Author)
                        .Select(book => $"[{book.BookID}] {book.Title} by {book.Author.Name}")
                        .ToList();
                    progress.Report(100);
                    return books;
                }
            }).ContinueWith(task =>
            {
                progressBar.Visible = false;
                return task.Result;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }



        public List<string> SearchBooks(string searchText)
        {
            using (var context = new BookstoreContext())
            {
                return context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Title.Contains(searchText) || b.Author.Name.Contains(searchText))
                    .Select(b => $"[{b.BookID}] {b.Title} by {b.Author.Name}")
                    .ToList();
            }
        }

        public bool UpdateBookAndAuthor(int bookId, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books
                    .Include(b => b.Author)
                    .FirstOrDefault(b => b.BookID == bookId);

                if (book == null) return false;

                book.Title = newTitle;
                book.Author.Name = newAuthorName;
                return context.SaveChanges() > 0;
            }
        }

        public bool DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Find(bookId);
                if (book == null) return false;

                context.Books.Remove(book);
                return context.SaveChanges() > 0;
            }
        }

        private void ClearTextBoxes()
        {
            txtAuthorName.Clear();
            txtBookTitle.Clear();
            txtBookID.Clear();
            txtSearch.Clear();
            txtNewAuthorName.Clear();
            txtNewBookTitle.Clear();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text;
            string bookTitle = txtBookTitle.Text;

            if (string.IsNullOrWhiteSpace(authorName) || string.IsNullOrWhiteSpace(bookTitle))
            {
                MessageBox.Show("Please enter both the author's name and the book title.");
                return;
            }

            try
            {
                AddAuthorWithBook(authorName, bookTitle);
                MessageBox.Show("Book added successfully!");
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                string errorMessage = $"Error: {ex.Message}";
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nInner Error: {ex.InnerException.Message}";
                }
                MessageBox.Show(errorMessage);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            var searchResults = SearchBooks(searchText);
            listBoxBooks.DataSource = searchResults;
        }

        private async void btnShowBooks_Click(object sender, EventArgs e)
        {
            var progress = new Progress<int>(value => progressBar.Value = value);
            var books_authors = await FetchBooksWithAuthorsAsync(progress);
            listBoxBooks.DataSource = books_authors;
        }


        private async void btnDeleteBook_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Please enter a valid numeric Book ID");
                return;
            }

            try
            {
                bool deleted = DeleteBook(bookId);
                if (deleted)
                {
                    MessageBox.Show("Book deleted successfully!");
                    ClearTextBoxes();
                    var updatedBooks = await FetchBooksWithAuthorsAsync(new Progress<int>());
                    listBoxBooks.DataSource = null;
                    listBoxBooks.DataSource = updatedBooks;
                }
                else
                {
                    MessageBox.Show("No book found with ID: " + bookId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting book: {ex.Message}\n{ex.InnerException?.Message}");
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtBookTitle.Text;
            string author = txtAuthorName.Text;

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show("Please enter both the book title and the author name.");
                return;
            }

            try
            {
                bool added = AddBookWithAuthor(title, author);
                if (added)
                {
                    MessageBox.Show("Book added successfully!");
                    txtAuthorName.Clear();
                    txtAuthorName.Clear();
                    var updatedBooks = await FetchBooksWithAuthorsAsync(new Progress<int>());
                    listBoxBooks.DataSource = null;
                    listBoxBooks.DataSource = updatedBooks;
                }
                else
                {
                    MessageBox.Show("Failed to add book.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding book: {ex.Message}\n{ex.InnerException?.Message}");
            }
        }

        private async void btnUpdateBook_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookID.Text, out int bookId))
            {
                MessageBox.Show("Please enter a valid numeric Book ID");
                return;
            }

            try
            {
                bool updated = UpdateBookAndAuthor(bookId, txtNewBookTitle.Text, txtNewAuthorName.Text);
                if (updated)
                {
                    MessageBox.Show("Book updated successfully!");
                    ClearTextBoxes();
                    var updatedBooks = await FetchBooksWithAuthorsAsync(new Progress<int>());
                    listBoxBooks.DataSource = null;
                    listBoxBooks.DataSource = updatedBooks;
                }
                else
                {
                    MessageBox.Show("No book found with ID: " + bookId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating book: {ex.Message}\n{ex.InnerException?.Message}");
            }
        }

        private void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };

                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        private bool AddBookWithAuthor(string title, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var author = context.Authors.FirstOrDefault(a => a.Name == authorName);
                if (author == null)
                {
                    author = new Author { Name = authorName };
                    context.Authors.Add(author);
                }

                var book = new Book { Title = title, Author = author };
                context.Books.Add(book);
                return context.SaveChanges() > 0;
            }
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            var searchResults = SearchBooks(searchText);
            listBoxBooks.DataSource = searchResults;
        }
    }
}
