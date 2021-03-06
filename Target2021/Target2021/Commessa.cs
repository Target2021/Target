﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Target2021
{
    class Commessa
    {
        public int IDCommessa { get; set; }
        public string CodCommessa { get; set; }
        public int NrCommessa { get; set; }
        public DateTime DataCommessa { get; set; }
        public int TipoCommessa { get; set; }
        public string IDCliente { get; set; }
        public string OrdCliente { get; set; }
        public DateTime DataConsegna { get; set; }
        public int NrPezziDaLavorare { get; set; }
        public string CodArticolo { get; set; }
        public string DescrArticolo { get; set; }
        public string Note { get; set; }
        public string Foto { get; set; }
        public string IDFornitore { get; set; }
        public int IDMachStampa { get; set; }
        public string IDStampo { get; set; }
        public string  CodArtiDopoStampo { get; set; }
        public int IDMachTaglio { get; set; }
        public string IDDima { get; set; }
        public string CodArtiDopoTaglio { get; set; }
        public string IDMateriaPrima { get; set; }
        public int NrLastreRichieste { get; set; }
        public string IDMinuteria { get; set; }
        public int Qtaminuteria { get; set; }
        public int NrPezziOrdinati { get; set; }
        public string NrOrdine { get; set; }
        public string LottoAcquisto { get; set; }
        public DateTime DataTermine { get; set; }
        public int NrPezziCorretti { get; set; }
        public int NrPezziScartati { get; set; }
        public DateTime OraInizioStampo { get; set; }
        public DateTime OraFineStampo { get; set; }
        public int SecondiCicloTaglio { get; set; }
        public int MinutiAttrezzaggio { get; set; }
        public int Stato { get; set; }
        public int ImpegnataMatPrima { get; set; }
        public string ProgrTaglio1 { get; set; }
        public string ProgrTaglio2 { get; set; }
        public int PercentualeUtilizzoLastra { get; set; }
        public int Mps { get; set; }
        public string ProgStampa { get; set; }
        public int PezziOra { get; set; }
        public int AttG1 { get; set; }
        public int AttG2 { get; set; }
        public int AttG3 { get; set; }
        public int AttG4 { get; set; }
        public int AttG5 { get; set; }

        public Commessa(int id)
        {
            NrCommessa = id;
        }

    }
}
