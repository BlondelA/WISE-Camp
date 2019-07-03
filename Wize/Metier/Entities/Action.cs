using System;
using System.Collections.Generic;
using System.Text;

namespace Metier.Entities
{
    class Action
    {
        public string rythmeFormation { get; set; }
        public string codePubliVise { get; set; }
        //public bool NiveauEntreeObligatoire { get; set; }
        public string modaliteAlternance { get; set; }
        // public ?? ModaliteEnseignement { get; set; }
        public string conditionSpecifiques { get; set; }
        //public bool PriseEnChargeFraisPossible { get; set; }
        public string lieuFormation { get; set; }
        //public ?? ModaliteEntreesSorties { get; set; }
        //public List<Session> Session { get; set; }
        public string restauration { get; set; }
        public string hebergement { get; set; }
        public string transport { get; set; }
        public string accesHandicapes { get; set; }
        public string langueFormation { get; set; }
        public string modlitesRecrutement { get; set; }
        public string modalitesPedagogiques { get; set; }
        //public ?? CodeModalitePedagogique { get; set; }
        public string fraisRestants { get; set; }
        //public ?? CodePerimetreRecrutement { get; set; }
        public string infosPerimetreRecrutement { get; set; }
        public string prixHoraireTTC { get; set; }
        public string prixTotalTTC { get; set; }
        public string dureeIndicative { get; set; }
        public int nombreHeuresCentre { get; set; }
        public int nombreHeuresEntreprise { get; set; }
        public int nombreHeuresTotal { get; set; }
        public string detailConditionsPriseEnCharge { get; set; }
        //public bool Conventionnement { get; set; }
        public int dureeConventionnee { get; set; }
        //public OrganismeFormateur{ get; set; }
        //public OrganismeFinanceur{ get; set; }
        public string financementFormation { get; set; }
        public int nbPlaces { get; set; }
        public string moyensPedagogiques { get; set; }
        //public  ResponsableEngagement { get; set; }
        public int nombreHeuresCm { get; set; }
        public int nombreHeuresTd { get; set; }
        public int nombreHeuresTpTuteure { get; set; }
        public int nombreHeuresTpNonTuteure { get; set; }
        public int nombreHeuresPersonnel { get; set; }

    }
}
