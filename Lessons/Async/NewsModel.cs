/*"category": "science",
   "data": [
       {
           "author": "Pragya Swastik",
           "content": "Gert-Jan Oskam, a 40-year-old man paralysed in a cycling accident 12 years ago, has been able to walk again by just thinking about it using electronic brain implants. \"We've created a wireless interface between the brain and spinal cord using a brain-computer interface,\" neuroscientists and neurosurgeons in Switzerland reported. At this stage, it has only been tested in one person.",
           "date": "24 May 2023,Wednesday",
           "id": "deb844eadf52433b9e8d6bff63f618da",
           "imageUrl": "https://static.inshorts.com/inshorts/images/v1/variants/jpg/m/2023/05_may/24_wed/img_1684948630751_21.jpg?",
           "readMoreUrl": "https://actu.epfl.ch/news/thought-controlled-walking-again-after-spinal-cord/?utm_campaign=fullarticle&utm_medium=referral&utm_source=inshorts ",
           "time": "10:52 pm",
           "title": "Brain implants help paralysed man walk again by just thinking about it",
           "url": "https://www.inshorts.com/en/news/brain-implants-help-paralysed-man-walk-again-by-just-thinking-about-it-1684948923037"
       }*/

public class NewsModel
{
    public string Category { get; set; }
    public List<NewsData> Data { get; set; }
}
public class NewsData
{
    public string Author { get; set; }
    public string Content { get; set; }
    public string Date { get; set; }
    public string Id { get; set; }
    public Uri ImageUrl { get; set; }
    public Uri ReadMoreUrl { get; set; }
    public string Time { get; set; }
    public string Title { get; set; }
    public Uri Url { get; set; }
}

