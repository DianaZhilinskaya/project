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
    
    public partial class Акции_на_товар
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Акции_на_товар()
        {
            this.Автозаправка = new HashSet<Автозаправка>();
        }
    
        public int Код_акции_товар { get; set; }
        public string Вид_акции { get; set; }
        public string Описание { get; set; }
        public int код_товара_на_акции { get; set; }
        public string Скидка_ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Автозаправка> Автозаправка { get; set; }
        public virtual Товар Товар { get; set; }
    }
}
