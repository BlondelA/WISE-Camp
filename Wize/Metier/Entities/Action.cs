using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Entities
{
    class Action
    {
        public string RythmeFormation { get; set; }
        public string CodePubliVise { get; set; }
        //public bool NiveauEntreeObligatoire { get; set; }
        public string ModaliteAlternance { get; set; }
        // public ?? ModaliteEnseignement { get; set; }
        public string ConditionSpecifiques { get; set; }
        //public bool PriseEnChargeFraisPossible { get; set; }
        public string LieuFormation { get; set; }
        //public ?? ModaliteEntreesSorties { get; set; }
        //public List<Session> Session { get; set; }
        public string Restauration { get; set; }
        public string Hebergement { get; set; }
        public string Transport { get; set; }
        public string AccesHandicapes { get; set; }
        public string LangueFormation { get; set; }
        public string ModlitesRecrutement { get; set; }
        public string ModalitesPedagogiques { get; set; }
        //public ?? CodeModalitePedagogique { get; set; }
        public string FraisRestants { get; set; }
        //public ?? CodePerimetreRecrutement { get; set; }
        public string InfosPerimetreRecrutement { get; set; }
        public string PrixHoraireTTC { get; set; }
        public string PrixTotalTTC { get; set; }
        public string DureeIndicative { get; set; }
        public int NombreHeuresCentre { get; set; }
        public int NombreHeuresEntreprise { get; set; }
        public int NombreHeuresTotal { get; set; }
        public string DetailConditionsPriseEnCharge { get; set; }
        //public bool Conventionnement { get; set; }
        public int DureeConventionnee { get; set; }
        //public OrganismeFormateur{ get; set; }
        //public OrganismeFinanceur{ get; set; }
        public string FinancementFormation { get; set; }
        public int NbPlaces { get; set; }
        public string MoyensPedagogiques { get; set; }
        //public  ResponsableEngagement { get; set; }
        public int NombreHeuresCm { get; set; }
        public int NombreHeuresTd { get; set; }
        public int NombreHeuresTpTuteure { get; set; }
        public int NombreHeuresTpNonTuteure { get; set; }
        public int NombreHeuresPersonnel { get; set; }

    }
}
