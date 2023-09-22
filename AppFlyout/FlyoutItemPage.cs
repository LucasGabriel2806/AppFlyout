using System;
using System.Collections.Generic;
using System.Text;

namespace AppFlyout
{
    class FlyoutItemPage
    {
        /**
         * Detalhes que eu quero ver na minha FlyoutPage
         */
        public string Title { get; set; }
        public string IconSource { get; set; }

        /**
         * Onde armazenamos nossa Page
         */
        public Type TargetPage { get; set; }

    }
}
