﻿using Microsoft.EntityFrameworkCore;

namespace APIMinima1
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options) : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();

    }
}
