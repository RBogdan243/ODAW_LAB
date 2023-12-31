﻿using Lab6.Models.Base;

namespace Lab6.Models.Many_to_Many
{
    public class Model4: BaseEntity
    {
        public string? Name { get; set; }

        // relation
        // public ICollection<Model3> Models3 {get; set;}
        public ICollection<ModelsRelation> ModelsRelations { get; set; }
    }
}
