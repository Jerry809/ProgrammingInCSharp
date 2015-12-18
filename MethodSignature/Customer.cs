using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSignature
{
    public class Customer
    {
        public int Points { get; private set; }

        // 公開方法、回傳值int 、名稱AddPoint、傳入一個參數、傳入型別int
        public int AddPoints(int pointsToAdd) 
        {
            this.Points += pointsToAdd;
            return Points;
        }

        // 公開方法、回傳值int 、名稱AddPoint、傳入兩個參數、傳入型別int
        public int AddPoints(int pointsToAdd, int masPoints)
        {
            Points += pointsToAdd;
            if (this.Points > masPoints )
            {
                this.Points = masPoints;
            }

            return this.Points;
        }

        public void Pay(int amount, string name = "Kevin", string method = "Cash") 
        {
            // TODO
        }
    }
}
