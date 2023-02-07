namespace UTS_NETLanjutan_DedeAdamAlamsyah.Models
{
	public class KoleksiBuku
	{
		public JudulBuku JudulBuku { get; set; }

		public KoleksiBuku(JudulBuku judulBuku)
		{
			JudulBuku = judulBuku;
		}

		public string GenreBuku
		{
			get
			{
				string genre = "";
				if (JudulBuku == JudulBuku.Komik_Black_Clover || JudulBuku == JudulBuku.Komik_One_Piece || JudulBuku == JudulBuku.Komik_Jujutsu_Kaisen)
				{
					genre = "Komik";
				}
				else if (JudulBuku == JudulBuku.Novel_Andrea_Hirata || JudulBuku == JudulBuku.Novel_JK_Rowling || JudulBuku == JudulBuku.Novel_Tere_Liye)
				{
					genre = "Novel";
				}
				else if (JudulBuku == JudulBuku.Sejarah_Indonesia || JudulBuku == JudulBuku.Sejarah_Yunani || JudulBuku == JudulBuku.Sejarah_Jepang)
				{
					genre = "Sejarah";
				}

				return genre;
			}
		}
	}
}
