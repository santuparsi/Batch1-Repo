using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDay2
{
	class TicketException:ApplicationException //userdefined exception class
	{
		string msg;

		public TicketException(string msg)
		{
			this.msg = msg;
		}
		public override string Message => msg;
	}
    internal class MovieTicket
    {
        public static void Book(int no)
        {
			try
			{
				if(no>5)
				{
					//throw the user-defined exception
					throw new TicketException("Transaction Failed\nReason:U can not book more than 4 tickets");
				}
				else
				{
					Console.WriteLine("Transaction Success..");
				}

			}
			catch (Exception)
			{

				throw;
			}
        }
		public static void Main()
		{
			try
			{
				Book(4);
				Book(10);
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
			}
		}
    }
}
