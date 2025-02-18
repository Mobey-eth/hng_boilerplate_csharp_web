﻿using Hng.Application.Features.Blogs.Dtos;
using MediatR;

namespace Hng.Application.Features.Blogs.Commands;

public class CreateBlogCommand(CreateBlogDto blogBody) : IRequest<BlogDto>, IRequest<CreateBlogResponseDto>
{
    public CreateBlogDto BlogBody { get; } = blogBody;
}