using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Repositorio
    {
        private IMongoCollection<Agenda> _agenda;

        public List<Agenda> ListaAgenda
        {
            get {
                var filter = Builders<Agenda>.Filter.Empty;
                return _agenda.Find<Agenda>(filter).ToList<Agenda>(); }
        }

        public void Create(Agenda agenda)
        {
            _agenda.InsertOne(agenda);
        }

        public void Delete(Agenda agenda)
        {
            var filter = Builders<Agenda>.Filter.Eq("Id", agenda.Id);
            _agenda.DeleteOne(filter);

        }

        public void Udpate (Agenda agenda)
        {
            var filter = Builders<Agenda>.Filter.Eq("Id", agenda.Id);
            var update = Builders<Agenda>.Update.Set("Nome", agenda.Nome).Set("Telefone", agenda.Telefone).Set("Endereco", agenda.Endereco);
        }

        public Repositorio()
        {
            var mongoClient = new MongoClient("mongodb+srv://breno215960:senha123@tarefasdb.bkjbssw.mongodb.net/");
            var mongoDatabase = mongoClient.GetDatabase("Agenda");
            _agenda = mongoDatabase.GetCollection<Agenda>("agenda");

        }
    }
   
}

