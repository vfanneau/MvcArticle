namespace MvcArticle.Models
{
    public class Article
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }

        public Article(int id, string title, string content)
        {
            this.id = id;
            this.title = title;
            this.content = content;
        }
    }
}
