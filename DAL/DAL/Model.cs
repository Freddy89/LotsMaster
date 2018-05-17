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
	}
	public class Person
	{
		public Person()
		{
			Lots = new List<Lot>();
			Histories = new List<LotHistory>();
		}
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string SecondName { get; set; }
		public bool Gender { get; set; }
		public string Image { get; set; }
		public string Email { get; set; } // ���� �� ����
		public string Password { get; set; }

		public virtual ICollection<Lot> Lots { get; set; }
		public virtual ICollection<LotHistory> Histories { get; set; }
	}

	public class Lot
	{
		public Lot()
		{
			History = new List<LotHistory>();
			TellPersonsAboutStart = new List<Person>();
		}
		public int Id { get; set; }
		public string LotName { get; set; }
		public string About { get; set; }
		public int StartPrice { get; set; } // �������� �� ������� � ��������
		public string Photo { get; set; } // ��� � �� ����� �� �� ����� ���� ��������� �� �볺��� �� ������, � ���� �� ��� �볺����
		public DateTime TimeStart { get; set; }
		public DateTime TimeFinish { get; set; }

		public Person WhoSale { get; set; }
		public virtual ICollection<LotHistory> History { get; set; }

		public virtual ICollection<Person> TellPersonsAboutStart { get; set; }
	}

	public class LotHistory  // ��� ����� �� ����� ������� 
	{
		public int Id { get; set; }
		public Lot Lot { get; set; }
		public Person Persson { get; set; }
		public int Money { get; set; }
	}
}