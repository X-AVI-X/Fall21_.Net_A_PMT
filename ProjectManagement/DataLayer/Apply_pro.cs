
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
    
public partial class Apply_pro
{

    public int Proj_Id { get; set; }

    public string MemId { get; set; }

    public string State { get; set; }

    public int App_Id { get; set; }



    public virtual C_Project C_Project { get; set; }

    public virtual MemLogin MemLogin { get; set; }

}

}
