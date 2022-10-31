using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuartsLateFeeCalculator
{
    public class RentalItem
    {
        // private properties - encapsulation
        private int stockNo;
        private string description;
        private string rating;

        // no prameter constructor - automatic default values when instantiated
        public RentalItem(){}

        // 3 parameter constructor
        public RentalItem(int stockNum, string descript, string ratings)
        {
            this.StockNo = stockNum;
            this.Description = descript;
            this.Rating = ratings;
        }

        // displays the stringified result of all the properties
        public string GetDisplayText(string sep)
        {
            return StockNo + sep + Description + sep + Rating;
        }

        //accessors - adding / setting public properties
        public int StockNo
        {
            get { return stockNo; }
            set { stockNo = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Rating
        {
            get { return rating; }
            set { rating = value; }
        }
    }
}
