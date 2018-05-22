namespace DAL
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Linq;
	using System.IO;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class AuctionContent : DbContext
	{
		public AuctionContent()
			: base("name=Model")
		{
		}
		public virtual DbSet<Person> Persons { get; set; }
		public virtual DbSet<Lot> Lots { get; set; }
		public virtual DbSet<LotHistory> History { get; set; }
        public virtual DbSet<Tell> Tells { get; set; }
	}
	public class Person
	{
		public Person()
		{
			Lots = new List<Lot>();
			Histories = new List<LotHistory>();
            Tells = new List<Tell>();
		}
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string SecondName { get; set; }
		public bool Gender { get; set; }
		public byte[] Image { get; set; }
		public string Email { get; set; } // ���� �� ����
		public string Password { get; set; }

		public virtual ICollection<Lot> Lots { get; set; }
		public virtual ICollection<LotHistory> Histories { get; set; }
        public virtual ICollection<Tell> Tells { get; set; }

    }

    public class Lot
	{
		public Lot()
		{
			History = new List<LotHistory>();
            Tells = new List<Tell>();
		}
		public int Id { get; set; }
		public string LotName { get; set; }
		public string About { get; set; }
		public int StartPrice { get; set; } // �������� �� ������� � ��������
		public byte[] Photo { get; set; } // ��� � �� ����� �� �� ����� ���� ��������� �� �볺��� �� ������, � ���� �� ��� �볺����
		public DateTime TimeStart { get; set; }
		public DateTime TimeFinish { get; set; }
        public virtual Person WhoSale { get; set; }
        public virtual ICollection<LotHistory> History { get; set; }
        public virtual ICollection<Tell> Tells { get; set; }
	}

    public class Tell
    {
        public int Id { get; set; }
        public virtual Person Person { get; set; }
        public virtual Lot Lot { get; set; }
    } 
	public class LotHistory  // ��� ����� �� ����� ������� 
	{
		public int Id { get; set; }
		public virtual Lot Lot { get; set; }
		public virtual Person Persson { get; set; }
		public int Money { get; set; }
	}
}