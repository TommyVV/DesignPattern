using DesignPattern.Proxy.Interface;
using System;
using System.Net;

namespace DesignPattern.Proxy.Implement
{
    public class GoogleProxy : ISearchEngine
    {
        private readonly ISearchEngine _vpn;

        public GoogleProxy()
        {
            _vpn = new Google();
        }

        public void Search(string searchStr)
        {
            try
            {
                _vpn.Search(searchStr);
            }
            catch (Exception)
            {
                string url = "https://www.baidu.com/s?wd=";
                var request = (HttpWebRequest)WebRequest.Create(url + searchStr);

                try
                {
                    var response = (HttpWebResponse)request.GetResponse();

                    if (response != null)
                    {
                        Console.WriteLine(string.Format("搜索【{0}】并成功返回！", searchStr));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
