
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DataLayer
{

using System;
    using System.Collections.Generic;
    
public partial class MemLogin
{

    public MemLogin()
    {

        this.Cnfrm_pro = new HashSet<Cnfrm_pro>();

    }


    public int Id { get; set; }

    public string User_Id { get; set; }

    public string Password { get; set; }

    public string Name { get; set; }

    public string Dept { get; set; }

    public string Credit { get; set; }



    public virtual ICollection<Cnfrm_pro> Cnfrm_pro { get; set; }

    public virtual Apply_pro Apply_pro { get; set; }

}

}
