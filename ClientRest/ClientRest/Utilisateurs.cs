using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRest
{
    
    class Utilisateurs
    {
        private string m_strId, m_strNom, m_strPrenom;

        public Utilisateurs(string id, string nom, string prenom)
        {
            m_strId = id;
            m_strNom = nom;
            m_strPrenom = prenom; 
        }

        public string getId()
        {
            return m_strId; 
        }

        public string getNom()
        {
            return m_strNom; 
        }

        public string prenom()
        {
            return m_strPrenom; 
        }
    }
}
