using Microsoft.EntityFrameworkCore;

Console.WriteLine();

public class ECommerceContext : DbContext
{
    public DbSet<Urun> Urunler {  get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=***, 1433;Database=***;User Id=***;Password=***");

        //Provider
        //ConnectionString
        //LazyLoading
        //vb.
    }
}

public class Urun
{
    //public int Id { get; set; }
    //public int ID { get; set; }
    //public int UrunId { get; set; }
    public int UrunID { get; set; }
}


#region OnConfiguring ile Konfigürasyon Ayarlarını Gerçekleştirmek
//EF Core toolunu yapılandırmak için kullandığımız bir metottur.
//Context nesnesinde override edilerek kullanılmaktadır.
#endregion
#region BAsit Düzeyde Entity Tanımlama Kuralları
//EF Core, her tablonun default olarak bir primary key kolonu olması gerektiğini kabul eder!
//Bu kolonu temsil eden bir property tanımlamadığımız takdirde hata verecektir!
#endregion
#region Tablo Adını Belirleme

#endregion