using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digikala_Sematech
{
    public class Product
    {
		private string _InvCode;
		private string _InvName;
		public int Stock { get; set; }
		public enum size
		{small,medium,large}
		public enum color
		{red,green,blue,gray,white}




        public string InvName
		{
			get { return _InvName; }
			set { _InvName = value; }
		}


		public string InvCode
		{
			get { return _InvCode; }
			set { _InvCode = value; }
		}


	}
}
