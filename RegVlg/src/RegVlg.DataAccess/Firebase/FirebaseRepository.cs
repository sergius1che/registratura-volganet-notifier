using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using RegVlg.Domain;

namespace RegVlg.DataAccess.Firebase
{
    public class FirebaseRepository : IFirebaseRepository, IRepository
    {
        private readonly FirestoreDb _db;

        public FirebaseRepository(string projetId)
        {
            _db = FirestoreDb.Create(projetId);
        }

        public async Task<T> Get<T>(Guid id)
            where T : IEntity
        {
            var query = _db.Collection(typeof(T).Name).WhereEqualTo(nameof(IEntity.Uid), id);
            var sn = await query.GetSnapshotAsync();
            return sn.Single().ConvertTo<T>();
        }

        public async Task Update<T>(T entity)
            where T : IEntity
        {
            entity.ChangeDateUtc = DateTime.UtcNow;
            var doc = _db.Collection(typeof(T).Name).Document(entity.Uid.ToString());
            var res = await doc.SetAsync(entity);
        }

        public async Task<T> Create<T>(T entity)
            where T : IEntity
        {
            entity.Uid = Guid.NewGuid();
            entity.InsertDateUtc = DateTime.UtcNow;
            entity.ChangeDateUtc = entity.InsertDateUtc;
            var result = await _db.Collection(typeof(T).Name).AddAsync(entity);
            var shot = await result.GetSnapshotAsync();
            return shot.ConvertTo<T>();
        }
    }
}
