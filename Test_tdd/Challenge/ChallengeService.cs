using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_tdd.Challenge
{
    public interface IChallengeService 
    {
        int Outlier(List<int> lst);
        int[] GetIntegerList(List<object> lst);
        string FormatWords(string[] words);

    }

    public class ChallengeService:IChallengeService
    {
        public ChallengeService() { }

        public int Outlier(List<int> lst) 
        {
            int _outlier = 0;

            if (lst.Count < 3) 
            {
                 throw new Exception("length minimiun is 3!");
            }

            List<bool> lstEven = lst.Select(a=>a%2==0).ToList();

            bool _isEven = (lstEven.Select(x => x == true).ToList().Count) >= 2 ? true : false;

            foreach (int item in lst)
            {
                bool even = item % 2 == 0;

                if (even)
                {
                    if (!_isEven) 
                    {
                        _outlier = item;
                        break;
                    }
                }
                else 
                {
                    if (_isEven) 
                    {
                        _outlier = item;
                        break;
                    }

                }
            }

            return _outlier;
        }

        public int[] GetIntegerList(List<object> lst) 
        {
            List<int> _lst = new List<int>();

            foreach (var item in lst)
            {

                if (item.GetType() == typeof(int)) 
                {
                    if ((int)item >= 0) 
                    {
                        _lst.Add((int)item);
                    }
                }
            }


            return _lst.ToArray();
        }

        public string FormatWords(string[] words) 
        {
            string _return = string.Empty;
            int _count = 0;

            foreach (string item in words)
            {
                _count++;

                if ((_count + 1) == words.Length)
                {
                    _return = _return + item + " and ";
                }
                else if (_count == words.Length)
                {
                    _return = _return + item;
                }
                else
                {
                    _return = _return + item + ", ";
                }
            }

            return _return;
        }
    }


}
