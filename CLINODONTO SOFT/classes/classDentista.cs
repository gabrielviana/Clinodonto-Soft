using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data;

namespace CLINODONTO_SOFT.classes
{
    public class classDentista
    {

        private int iddentista;
        private string cpf;
        private string rg;
        private string orgaoexpedidor;
        private string nome;
        private string cro;
        private string login;
        private string senha;
        private int tipo;
        private int telefone;
        private string endereco;
        //////////////////////////////
      
        private string seg_mat;
        private string seg_vesp;
        private string seg_noturno;

        private string ter_mat;
        private string ter_vesp;
        private string ter_noturno;
        
        private string qua_mat;
        private string qua_vesp;
        private string qua_noturno;

        private string qui_mat;
        private string qui_vesp;
        private string qui_noturno;

        private string sex_mat;
        private string sex_vesp;
        private string sex_noturno;
       
        public int Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public int Iddentista
        {
            get { return iddentista; }
            set { iddentista = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public string Orgaoexpedidor
        {
            get { return orgaoexpedidor; }
            set { orgaoexpedidor = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
      
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
       
      
       

        public string Cro
        {
            get { return cro; }
            set { cro = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Seg_mat
        {
            get { return seg_mat; }
            set { seg_mat = value; }
        }
        public string Seg_vesp
        {
            get { return seg_vesp; }
            set { seg_vesp = value; }
        }
        public string Seg_not
        {
            get { return seg_noturno; }
            set { seg_noturno = value; }
        }

        public string Ter_mat
        {
            get { return ter_mat; }
            set { ter_mat = value; }
        }
        public string Ter_vesp
        {
            get { return ter_vesp; }
            set { ter_vesp = value; }
        }
        public string Ter_not
        {
            get { return ter_noturno; }
            set { ter_noturno = value; }
        }

        public string Qua_mat
        {
            get { return qua_mat; }
            set { qua_mat = value; }
        }
        public string Qua_vesp
        {
            get { return qua_vesp; }
            set { qua_vesp = value; }
        }
        public string Qua_not
        {
            get { return qua_noturno; }
            set { qua_noturno = value; }
        }

        public string Qui_mat
        {
            get { return qui_mat; }
            set { qui_mat = value; }
        }
        public string Qui_vesp
        {
            get { return qui_vesp; }
            set { qui_vesp = value; }
        }
        public string Qui_not
        {
            get { return qui_noturno; }
            set { qui_noturno = value; }
        }

        public string Sex_mat
        {
            get { return sex_mat; }
            set { sex_mat = value; }
        }
        public string Sex_vesp
        {
            get { return sex_vesp; }
            set { sex_vesp = value; }
        }
        public string Sex_not
        {
            get { return sex_noturno; }
            set { sex_noturno = value; }
        }


        
        public ArrayList buscar(string bus)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM dentista where nome like '%" + bus + "%' or cro like '%" + bus + "%';";  
         
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                  classDentista de = new classDentista();
                  de.login = dt.Rows[i][6].ToString();
                  de.senha = dt.Rows[i][7].ToString();
                    de.Iddentista = int.Parse(dt.Rows[i][0].ToString());
                    de.cpf = dt.Rows[i][1].ToString();

                    de.rg = dt.Rows[i][2].ToString();
                    de.orgaoexpedidor = dt.Rows[i][3].ToString();
                    de.nome = dt.Rows[i][4].ToString();
                    de.cro = dt.Rows[i][5].ToString();
                  
                    de.tipo = int.Parse(dt.Rows[i][8].ToString());
                    de.endereco = dt.Rows[i][9].ToString();
                    de.telefone = int.Parse(dt.Rows[i][10].ToString());
                    arr.Add(de);
                    i++;
                }
            }
            return arr;
        }
        public ArrayList bucaverificar(string cr, string lo)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM dentista where cro = '" + cr + "' or login ='" + lo + "';";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    classDentista de = new classDentista();
                    de.login = dt.Rows[i][6].ToString();
                    de.senha = dt.Rows[i][7].ToString();
                    de.Iddentista = int.Parse(dt.Rows[i][0].ToString());
                    de.cpf = dt.Rows[i][1].ToString();

                    de.rg = dt.Rows[i][2].ToString();
                    de.orgaoexpedidor = dt.Rows[i][3].ToString();
                    de.nome = dt.Rows[i][4].ToString();
                    de.cro = dt.Rows[i][5].ToString();

                    de.tipo = int.Parse(dt.Rows[i][8].ToString());
                    de.endereco = dt.Rows[i][9].ToString();
                    de.telefone = int.Parse(dt.Rows[i][10].ToString());
                    arr.Add(de);
                    i++;
                }
            }
            return arr;
        }
        public ArrayList bucareditar(string ID)
        {
            ArrayList arr = new ArrayList();
            string sql = "SELECT * FROM dentista where iddentista = '" + ID + "';";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            if (dt != null)
            {
                int i = 0;
                while (i < dt.Rows.Count)
                {
                    classDentista de = new classDentista();
                    de.login = dt.Rows[i][6].ToString();
                    de.senha = dt.Rows[i][7].ToString();
                    de.Iddentista = int.Parse(dt.Rows[i][0].ToString());
                    de.cpf = dt.Rows[i][1].ToString();

                    de.rg = dt.Rows[i][2].ToString();
                    de.orgaoexpedidor = dt.Rows[i][3].ToString();
                    de.nome = dt.Rows[i][4].ToString();
                    de.cro = dt.Rows[i][5].ToString();

                    de.tipo = int.Parse(dt.Rows[i][8].ToString());
                    de.endereco = dt.Rows[i][9].ToString();
                    de.telefone = int.Parse(dt.Rows[i][10].ToString());
                    arr.Add(de);
                    i++;
                }
            }
            return arr;
        }
        
        public void Salvar()
        {
            string sql = "INSERT INTO dentista(cpf,rg,orgao_expedidor,nome,cro,login,senha,tipo,endereco,telefone) VALUES(" + Cpf + "," + Rg + ",'" + Orgaoexpedidor + "','" + Nome + "','" + Cro + "','" + Login + "','" + Senha + "','" + Tipo + "','" + Endereco + "'," + Telefone + ");";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void Editar(string id)
        {
            string sql = "UPDATE dentista set cpf = '" + Cpf + "',rg = '" + Rg + "',orgao_expedidor = '" + Orgaoexpedidor + "',nome = '" + Nome + "',cro = '" + Cro + "',login = '" + Login + "',senha = '" + Senha + "',tipo = '" + Tipo + "' ,endereco = '" + Endereco + "',telefone = '" + Telefone + "' where iddentista = '" + id + "';";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);

            try
            {
                Conn.ExecuteNonQuery(commS);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int bucarconsulta(string id)
        {
            string sql = "SELECT * FROM consulta where dentista = '" + id + "';";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            return dt.Rows.Count;
        }
        public int bucarficha(string id)
        {
            string sql = "SELECT * FROM ficha_clinica where id_dentista = '" + id + "';";
            MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
            DataTable dt = Conn.ExecuteQuery(commS);
            return dt.Rows.Count;
        }
       
        public string Deletar(string idd)
        {
            classDentista dent = new classDentista();
                string sql = "DELETE FROM dentista WHERE iddentista = '" + idd + "';";
                MySqlCommand commS = new MySqlCommand(sql, Conn.mConn);
                if (dent.bucarficha(idd) == 0 || dent.bucarconsulta(idd) == 0)
                {
                    try
                    {
                        Conn.ExecuteNonQuery(commS);

                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    return "1";

                }
                else
                {
                    return "0";
                }
           
        }

     
    }
}
