//------------------------------------------------------------------------------
// <auto-generated>
//    Bu kod bir şablondan oluşturuldu.
//
//    Bu dosyada el ile yapılan değişiklikler uygulamanızda beklenmedik davranışa neden olabilir.
//    Kod yeniden oluşturulursa, bu dosyada el ile yapılan değişikliklerin üzerine yazılacak.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ezgıelıfproje
{
    using System;
    using System.Collections.Generic;
    
    public partial class RECIPE_STEP
    {
        public int ID { get; set; }
        public int RECIPE_ID { get; set; }
        public int RECIPE_ITEM_ID { get; set; }
        public int RECIPE_STEP_SEQ { get; set; }
        public string RECIPE_STEP_DESC { get; set; }
        public System.DateTime RECIPE_STEP_LOGDATETIME { get; set; }
        public string RECIPE_STEP_CREATEDBY { get; set; }
    }
}
