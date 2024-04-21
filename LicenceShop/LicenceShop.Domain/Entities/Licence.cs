using MongoDB.Entities;

namespace LicenceShop.Domain.Entities;


[Collection("licences")]
public class Licence : BaseEntity
{
    #region Properties
    
    [Field("name")]
    public string Name { get; set; }
    
    [Field("start_date")]
    public DateTime StartDate { get; set;}
    
    [Field("end_date")]
    public DateTime EndDate { get; set; }
    
    [Field("vendor")]
    public One<Vendor> Vendor { get; set; }
    
    [Field("category")]
    public One<Category> Category { get; set; }
    
    [Field("type")]
    public One<LicenceType> Type { get; set; }
    
    [Field("owner")]
    public One<ApplicationUser> Owner { get; set; }
    
    [Field("sold")]
    public bool IsSold { get; set; }
    
    [Field("price")]
    public double Price { get; set; }

    [Field("img")]
    public string Img { get; set; }
    
    [Field("description")]
    public string Description { get; set;}

    #endregion


    #region Constructors

    public Licence()
    {
    }

    #endregion

    #region Methods

    public Licence AddOwner(One<ApplicationUser> owner)
    {
        Owner = owner;
        return this;
    }

    public Licence AddVendor(One<Vendor> vendor)
    {
        Vendor = vendor;
        return this;
    }
    
    public Licence AddCategory(One<Category> category)
    {
        Category = category;
        return this;
    }
    
    public Licence AddType(One<LicenceType> type)
    {
        Type = type;
        return this;
    }
    

    #endregion
    
    
}