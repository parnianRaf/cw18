using AppCore.Entity;
using Microsoft.EntityFrameworkCore;

namespace SqlDataBase;
public class LibraryDbContext:DbContext
{


    public LibraryDbContext()
    {

    }

    public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
    {

    }





    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Book>(b =>
        {
            //b.HasMany(b => b.MemberBooks).WithOne(b => b.Books).HasForeignKey(b => b.BookId);
            b.HasOne(b => b.Genre).WithMany(b => b.Books).HasForeignKey(m=>m.GenreId);
            b.HasData(new Book()
            {
                Id=1,
                BookName="Harry Potter",
                GenreId=1

            });
        });


        modelBuilder.Entity<Member>(m =>
        {
            //m.HasMany(m => m.MemberBooks).WithOne(m => m.Members).HasForeignKey(m => m.MemberId);
            m.HasOne(m => m.Address).WithOne(m => m.Member).HasForeignKey<Addresss>(m=>m.Id);
            m.HasData(new Member()
            {
                 Id=1,
                 FirstName="PArnian",
                 LastName="Rafie"
            });
        });

        modelBuilder.Entity<MemberBook>(m =>
        {
            m.HasKey(key => new { key.BookId, key.MemberId });
            m.HasOne(m => m.Books).WithMany(m => m.MemberBooks).HasForeignKey(m => m.BookId);
            m.HasOne(m => m.Members).WithMany(m => m.MemberBooks).HasForeignKey(m => m.MemberId);
            m.HasData(new MemberBook()
            {
                 BookId=1,
                 MemberId=1
            });
        });


        modelBuilder.Entity<Addresss>(a =>
        {
            a.HasOne(a => a.City).WithMany(a => a.Addressses).HasForeignKey(c=>c.CityId);
            a.HasData(new Addresss()
            {
                 Id=1,
                  CityId=1,
                   AddressDes="Home",
                    Description="Home is Home"
            });
        });


        modelBuilder.Entity<City>(c =>
        {
            c.HasOne(c=>c.Province).WithMany(c=>c.Cities).HasForeignKey(p=>p.ProvinceId);
            c.HasData(new City()
            {
                 Id=1,
                  Name="tehran",
                   ProvinceId=1
            });
        });


        modelBuilder.Entity<Genre>(c =>
        {
            c.HasData(new Genre()
            {
                 Id=1,
                 GenreName="Fiction"
            });
        });

        modelBuilder.Entity<Province>(c =>
        {
            c.HasData(new Province()
            {
                Id = 1,
                 ProvinceName="tehran"
             
            });
        });


    }



    public DbSet<Book> Books { get; set; }
    public DbSet<Addresss> Addressses { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<MemberBook> MemberBooks { get; set; }
    public DbSet<City> City { get; set; }
    public DbSet<Genre> Genre { get; set; }
    public DbSet<Province> Province { get; set; }

}

