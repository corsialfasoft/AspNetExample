using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMVCExample.Models {
    public interface ITournement{
        void Save(TorneoModel torneo);
    }
    public class DomainModel : ITournement {
        public void Save(TorneoModel torneo) {
            throw new NotImplementedException();
        }
    }
}