using DesignPattern.Proxy.Interface;
using System;
using System.Net;

namespace DesignPattern.Proxy.Implement
{
    public class Google : ISearchEngine
    {
        public void Search(string searchStr)
        {
            string url = "https://www.google.com/search?q=";
            var request = (HttpWebRequest)WebRequest.Create(url + searchStr);

            var response = (HttpWebResponse)request.GetResponse();

            if (response != null)
            {
                Console.WriteLine(string.Format("搜索【{0}】并成功返回！", searchStr));
            }
        }
    }
}
