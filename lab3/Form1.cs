using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string? Title { get; set; }
            public string? Author { get; set; }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} | Issue: {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public string? Platform { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} | Platform: {Platform}";
            }
        }

        public class TextBook : Book
        {
            public string? Subject { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} | Subject: {Subject}";
            }
        }

        public class Audiobook : Book
        {
            public string? Narrator { get; set; }
            public int Duration { get; set; }
            public override string GetInfo()
            {
                return $"{Title} by {Author} | Narrated by: {Narrator} | Duration: {Duration} minutes";
            }
        }

        private void btnShowBookInfo_Click(object sender, EventArgs e)
        {
            Book myBook = new Magazine()
            {
                Title = "Tech Weekly",
                Author = "John Doe",
                IssueNumber = 45
            };
            MessageBox.Show(myBook.GetInfo());
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            Book[] books = {
                new Magazine() { Title = "Sports Illustrated", Author = "Editorial Board", IssueNumber = 98 },
                new Ebook() { Title = "Digital Marketing 101", Author = "Lisa Green", Platform = "Google Books" },
                new TextBook() { Title = "Software Design", Author = "Andrew Bell", Subject = "Computer Science" },
                new Audiobook() { Title = "The Art of War", Author = "Sun Tzu", Narrator = "Morgan Freeman", Duration = 200 }
            };

            listBoxBooks.Items.Clear();
            foreach (var book in books)
            {
                listBoxBooks.Items.Add(book.GetInfo());
            }
        }
    }
}
