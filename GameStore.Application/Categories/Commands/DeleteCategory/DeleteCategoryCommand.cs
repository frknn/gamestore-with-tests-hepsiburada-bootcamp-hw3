using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Categories.Commands.DeleteCategory
{
  public class DeleteCategoryCommand : IRequest
  {
    public Guid Id { get; set; }
  }
}
