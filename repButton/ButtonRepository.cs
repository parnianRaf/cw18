using AppCore.DTO;
using SqlDataBase;

namespace repButton;
public class buttonRepository : IbuttonRepository
{
    private readonly LibraryDbContext _libraryDB;
    //public buttonRepository(LibraryDbContext libraryDB)
    //{

    //    _libraryDB = libraryDB;
    //}



    //public List<ProvinceMemberList> ProvinceMemberList()
    //{

    //    List<ProvinceMemberList>  Member=_libraryDB.Province
    //        .Select(p => new ProvinceMemberList()
    //    {

    //        Id = p.Id,
    //        Name = p.ProvinceName,
    //        listMemberName = p.Cities.Select(c => c.Addressses.Select(a => a.Member).FirstOrDefault()).Select(m => m.FirstName + " " + m.LastName).ToList()

    //    }).ToList();
    //    return Member;
       
    //}

}

