using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddsAndEnds
{
    public class SnowflakeDataContext : DbContext
    {
        public SnowflakeDataContext() : base("Snowflake")
        {
            var ensureDllIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        //SQL Tables
        public IDbSet<Choice> Choices { get; set; }

        //Model Relationships
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Conversation
            modelBuilder.Entity<Conversation>()
                        .HasMany(c => c.Messages)
                        .WithRequired(m => m.Conversation)
                        .HasForeignKey(m => m.ConversationId);

            modelBuilder.Entity<Conversation>()
                        .HasMany(c => c.Participations)
                        .WithRequired(p => p.Conversation)
                        .HasForeignKey(p => p.ConversationId);

            // Making a Composite Key
            modelBuilder.Entity<Participation>()
                        .HasKey(p => new { p.UserId, p.ConversationId });


            base.OnModelCreating(modelBuilder);
        }
    }
}

