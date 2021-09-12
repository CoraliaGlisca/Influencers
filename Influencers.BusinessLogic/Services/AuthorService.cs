using Influencers.Models.Model;
using Influencers.Repository.Abstractions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Influencers.BusinessLogic.Services
{
    public class AuthorService
    {
        private IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
     
        public bool CheckIfAuthorExists(string email)
        {
            return _authorRepository.CheckIfAuthorExists(email);
        }
        
        public Author AddAuthor(          
            string nickname, 
            string firstName, 
            string lastName, 
            string email, 
            int votes, 
            string description
            )
        {
            var art= _authorRepository.Add(new Author()
            {
                //Id = id,
                NickName = nickname,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Votes = votes,
                //Image = image,
                Description = description
            });
            return art;
        }

        public string GetNicknameById(int Id)
        {
            return _authorRepository.GetNicknameById(Id);
        }

        public int GetAuthorIdByEmail(string Nickname)
        {
            return _authorRepository.GetAuthorIdByEmail(Nickname);
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return _authorRepository.GetAll();
        }

        public int GetAuthorIdByArticleId(int id)
        {
            return _authorRepository.GetAuthorIdByArticleId(id);

        }
        public Author GetAuthorById(int id)
        {
            return _authorRepository.GetAuthorById(id);
        }

        public void AddVote(int authorId, int votes)
        {
            var author = _authorRepository.GetAuthorById(authorId);
            author.AddVote(votes);
            _authorRepository.Update(author);
        }

        public string GetAuthorEmailbyAuthorId(int id)
        {
            return _authorRepository.GetAuthorEmailByAuthorId(id);
        }

        public void UploadFile(IFormFile file, int id)
        {
            var fileName = file.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            var author = _authorRepository.UploadAuthorFile(id);
            author.Image = fileName;
            _authorRepository.Update(author);
        }

    }
}
