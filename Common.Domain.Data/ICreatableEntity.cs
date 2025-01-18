﻿namespace Common.Domain.Data
{
    public interface ICreatableEntity
    {
        DateTime DateCreated { get; set; }
        int? AuthorId { get; set; }

        void SetAuthor(int? authorId)
        {
            DateCreated = DateTime.Now;
            AuthorId = authorId;
        }
    }
}
