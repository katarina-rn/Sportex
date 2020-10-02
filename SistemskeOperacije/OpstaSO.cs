using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using BrokerBazePodataka;

namespace SistemskeOperacije
{
    public abstract class OpstaSO
    {
        public Object IzvrsiSO(IDomenskiObjekat odo)
        {
            Object rezultat = null;
            Broker.Instance().OpenConnection();
            Broker.Instance().BeginTransaction();
            try
            {
                rezultat = Izvrsi(odo);
                Broker.Instance().Commit();
            }
            catch (Exception )
            {
                //throw ex;
                Broker.Instance().Rollback();
            }
            finally
            {
                Broker.Instance().CloseConnection();
            }

            return rezultat;
        }

        protected abstract object Izvrsi(IDomenskiObjekat odo);
    }
}
