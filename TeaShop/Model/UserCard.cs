//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeaShop.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserCard
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BankCardId { get; set; }
    
        public virtual BankCard BankCard { get; set; }
        public virtual User User { get; set; }
    }
}