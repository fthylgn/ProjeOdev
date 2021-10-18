using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using HtmlAgilityPack;
using Microsoft.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {
        IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public Article GetByID(int id)
        {
            return _articleDal.GetByID(id);
        }

        public List<Article> GetList()
        {
            return _articleDal.GetListAll();
        }

        public void ArticleAdd(Article article)
        {
            _articleDal.Insert(article);
        }

        public void ArticleDelete(Article article)
        {
            _articleDal.Delete(article);
        }

        public void ArticleUpdate(Article article)
        {
            _articleDal.Update(article);
        }

        public List<Article> GetLastArticles()
        {
            Uri url = new Uri("https://www.wired.com/most-recent/");
            WebClient client = new WebClient();
            string html = client.DownloadString(url);

            HtmlDocument dokuman = new HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection basliklar = dokuman.DocumentNode.SelectNodes(".//div[@class='archive-list-component archive-list-component--']/ul/li");
            List<Article> articles = new List<Article>();
            int count = 0;
            foreach (var htmlNode in basliklar)
            {
                string nodeUrl = htmlNode.SelectSingleNode(".//a[@class='archive-item-component__link']").Attributes["href"].Value.ToString();
                string nodeHeader = htmlNode.SelectSingleNode(".//h2[@class='archive-item-component__title']").InnerText;
                nodeHeader = HttpUtility.HtmlDecode(nodeHeader);
                string content = htmlNode.SelectSingleNode(".//p[@class='archive-item-component__desc']").InnerText;
                List<string> lngcontent;
                if (nodeUrl.Contains("gallery"))
                {
                    lngcontent = LoadFullContentGallery(nodeUrl);
                }
                else if (nodeUrl.Contains("2021"))
                {
                    lngcontent = LoadFullContentAction(nodeUrl);
                }
                else
                {
                    lngcontent = LoadFullContent(nodeUrl);
                }

                Article article = new Article();
                article.ArticleTitle = nodeHeader;
                article.ArticleUrl = nodeUrl;
                List<Paragraph> paragraphs = new List<Paragraph>();
                foreach (var item in lngcontent)
                {
                    Paragraph p = new Paragraph();
                    p.ParagraphText = item;
                    paragraphs.Add(p);
                }
                article.Paragraphs = paragraphs;
                article.ArticleID = count;
                articles.Add(article);
                count++;
                if (count == 5)
                    break;
            }

            return articles;
        }




        private string Clean(String str)
        {
            string aposhtml = "&#x27;";
            string aposunicode = "&#8217;";
            string apos = "'";

            string tırnak = "" + '"';
            string tırnakhtml = "&quot;";
            string tırnakunicode = "&#8221;";
            string tırnakunicode2 = "&#8220;";

            str = str.Replace(aposunicode, apos).Replace(aposhtml, apos);
            str = str.Replace(tırnakunicode, tırnak).Replace(tırnakunicode2,tırnak).Replace(tırnakhtml, tırnak);
            return str;
        }
        private List<string> LoadFullContent(string str)
        {
            Uri url = new Uri("https://www.wired.com" + str);
            WebClient client = new WebClient();
            string html = client.DownloadString(url);

            HtmlDocument dokuman = new HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection basliklar = dokuman.DocumentNode.SelectNodes(".//div[@class='body__inner-container']/p");

            List<string> prg = new List<string>();
            int count = 0;
            foreach (var htmlNode in basliklar)
            {
                if (!htmlNode.InnerText.Contains("This story originally appeared on WIRED UK."))
                {
                    prg.Add(Clean(htmlNode.InnerText));
                }

                count++;
            }
            return prg;
        }
        private List<string> LoadFullContentGallery(string str)
        {
            Uri url = new Uri("https://www.wired.com" + str);
            WebClient client = new WebClient();
            string html = client.DownloadString(url);

            HtmlDocument dokuman = new HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection basliklar = dokuman.DocumentNode.SelectNodes(".//div[@class='BaseWrap-sc-TURhJ BodyWrapper-ctnerm jOLcNp bIIuTQ body GalleryPageIntroBody-kVyaEU bFuCtG']/div/p");

            List<string> prg = new List<string>();
            int count = 0;
            foreach (var htmlNode in basliklar)
            {
                prg.Add(Clean(htmlNode.InnerText));
                count++;
            }
            return prg;
        }
        private List<string> LoadFullContentAction(string str)
        {
            Uri url = new Uri("https://www.wired.com" + str);
            WebClient client = new WebClient();
            string html = client.DownloadString(url);

            HtmlDocument dokuman = new HtmlDocument();
            dokuman.LoadHtml(html);
            HtmlNodeCollection basliklar = dokuman.DocumentNode.SelectNodes(".//div[@class='body__inner-container']/p");

            List<string> prg = new List<string>();
            int count = 0;
            foreach (var htmlNode in basliklar)
            {
                if (!htmlNode.InnerText.Contains("This story originally appeared on WIRED UK."))
                {
                    prg.Add(Clean(htmlNode.InnerText));
                }

                count++;
            }
            return prg;
        }

        public Article GetByIDWithQuestions(int id)
        {
           return _articleDal.GetByIDWithQuestion(id);
        }
    }
}
