using MongoDB.Driver;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class DataAccess
    {
        private const string ConnectionString = "mongodb+srv://jnlavrov34:Armagidon2024@cluster.tsc3e.mongodb.net/";
        private const string DBName = "PopcornPalms";
        private const string UserConnection = "users";

        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(DBName);

            return db.GetCollection<T>(collection);
        }

        public Task CreateUser(User user)
        {
            var UserCollection = ConnectToMongo<User>(UserConnection);
            var newUser = UserCollection.InsertOneAsync(user);
            return newUser;
        }
        public async Task<User> FindUser(string login, string password)
        {
            var UserCollection = ConnectToMongo<User>(UserConnection);
            var people = await UserCollection.Find(user => user.Login == login && user.Password == password).FirstOrDefaultAsync();
            return people;
        }
        public async Task<User> OutUser(string id)
        {
            var UserCollection = ConnectToMongo<User>(UserConnection);
            var people = await UserCollection.Find(user => user.Id == id).FirstOrDefaultAsync();
            return people;
        }
        public Task CreateTicket(Ticketss ticketss)
        {
            var TicketCollection = ConnectToMongo<Ticketss>("ChoosePlace");
            var newTicket = TicketCollection.InsertOneAsync(ticketss);
            return newTicket;
        }
        public async Task<Ticketss> OutTicket(string nameofTicket)
        {
            var TicketCollection = ConnectToMongo<Ticketss>("ChoosePlace");
            var ticket = await TicketCollection.Find(tickets => tickets.NameofTicket == nameofTicket).FirstOrDefaultAsync();
            return ticket;
        }
        public Task CreatePopcorn(Popcorns popcorns)
        {
            var PopcornCollection = ConnectToMongo<Popcorns>("Popcorn");
            var newPopcorn = PopcornCollection.InsertOneAsync(popcorns);
            return newPopcorn;
        }
        public async Task<Popcorns> OutPopcorn(string popcornVolume)
        {
            var PopcornCollection = ConnectToMongo<Popcorns>("Popcorn");
            var popcorn = await PopcornCollection.Find(popcorns => popcorns.PopcornVolume == popcornVolume).FirstOrDefaultAsync();
            return popcorn;
        }
        public Task CreateCard(Card card)
        {
            var CardCollection = ConnectToMongo<Card>("Card");
            var newCard = CardCollection.InsertOneAsync(card);
            return newCard;
        }
        public async Task<Card> OutCard(string id)
        {
            var PopcornCollection = ConnectToMongo<Card>("Card");
            var card = await PopcornCollection.Find(cards => cards.Id == id).FirstOrDefaultAsync();
            return card;
        }
        public Task CreateQuestions(Questionss questions)
        {
            var QuestionsCollection = ConnectToMongo<Questionss>("Question");
            var newQuestion = QuestionsCollection.InsertOneAsync(questions);
            return newQuestion;
        }
        public async Task<Questionss> FindQuestion(string id)
        {
            var QuestionCollection = ConnectToMongo<Questionss>("Question");
            var question = await QuestionCollection.Find(questions => questions.Id == id).FirstOrDefaultAsync();
            return question;
        }
        public async Task<List<Questionss>> getQuestion()
        {
            var QuestionCollection = ConnectToMongo<Questionss>("Question");
            var rat = await QuestionCollection.FindAsync(_ => true);
            return rat.ToList();
        }
        public async Task UpdateQuestion(string questionId, string status)
        {
            var QuestionCollection = ConnectToMongo<Questionss>("Question");
            var filter = Builders<Questionss>.Filter.Eq(u => u.Id, questionId);
            var update = Builders<Questionss>.Update.Set(u => u.StatusQuestion, status);
            await QuestionCollection.UpdateOneAsync(filter, update);
        }
    }
}