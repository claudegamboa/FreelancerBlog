﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FreelancerBlog.Core.Commands.Data.SlideShows;
using FreelancerBlog.Data.EntityFramework;
using MediatR;

namespace FreelancerBlog.Data.Commands.SlideShows
{
    public class DeleteSlideShowCommandHandler : AsyncRequestHandler<DeleteSlideShowCommand>
    {
        private FreelancerBlogContext _context;

        public DeleteSlideShowCommandHandler(FreelancerBlogContext context)
        {
            _context = context;
        }

        protected override Task Handle(DeleteSlideShowCommand message, CancellationToken cancellationToken)
        {
            _context.SlideShows.Remove(message.SlideShow);

            return _context.SaveChangesAsync(cancellationToken);
        }
    }
}