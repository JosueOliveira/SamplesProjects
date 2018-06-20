using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class PedidoWeb : BaseObject
    {
        private int _codigo;
        private bool _alteracao;
        public PedidoWeb (Session session) : base(session) { }


        public int Codigo
        {
            get { return _codigo; }
            set { SetPropertyValue("Codigo", ref _codigo, value); }
        }

        public bool Alteracao
        {
            get { return _alteracao; }
            set { SetPropertyValue("Alteracao", ref _alteracao, value); }
        }
    }
}
