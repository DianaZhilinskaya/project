//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Чек
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Чек()
        {
            this.ЧекТовар = new HashSet<ЧекТовар>();
            this.ЧекУслуга = new HashSet<ЧекУслуга>();
        }
    
        public int код_чека { get; set; }
        public Nullable<System.DateTime> дата { get; set; }
        public int код_топлива { get; set; }
        public int кол_во_топлива { get; set; }
        public Nullable<int> номер_карточки_клиента { get; set; }
        public decimal стоимость { get; set; }
        public Nullable<int> скидка { get; set; }
    
        public virtual Постоянные_клиенты Постоянные_клиенты { get; set; }
        public virtual Топливо Топливо { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ЧекТовар> ЧекТовар { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ЧекУслуга> ЧекУслуга { get; set; }
    }
}
