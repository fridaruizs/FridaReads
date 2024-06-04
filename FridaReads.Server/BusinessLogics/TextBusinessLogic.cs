using AutoMapper;
using FridaReads.Server.Entities;
using FridaReads.Server.Models;
using FridaReads.Server.Repositories;

namespace FridaReads.Server.BusinessLogics
{
    public class TextBusinessLogic
    {
        private readonly TextRepository _textRepository;
        private readonly UserBusinessLogic _userBusinessLogic;
        private readonly IMapper _mapper;

        public TextBusinessLogic(TextRepository textRepository,UserBusinessLogic userBusinessLogic, IMapper mapper)
        {
            _textRepository = textRepository;
            _userBusinessLogic = userBusinessLogic;
            _mapper = mapper;
        }

        public async Task<TextModel> AddText(TextModel textModel)
        {
            var text = _mapper.Map<Text>(textModel);
            var addedText = await _textRepository.AddAsync(text);
            return _mapper.Map<TextModel>(addedText);
        }

        public async Task<TextModel> UpdateTextReview(TextModel textModel)
        {
            var text = _mapper.Map<Text>(textModel);
            var updatedText = await _textRepository.UpdateAsync(text);
            return _mapper.Map<TextModel>(updatedText);
        }

        public async Task DeleteTextReview(TextModel textModel)
        {
            var text = _mapper.Map<Text>(textModel);
            await _textRepository.DeleteAsync(text);
        }

        public async Task<List<Text>> GetTextByUser(string email)
        {
            var userId = _userBusinessLogic.GetUserByEmail(email).Id;
            var texts = await _textRepository.GetByUserIdAsync(userId);
            return texts;
        }
        public async Task<List<Text>> GetTextByUserId(int id)
        {
            var texts = await _textRepository.GetByUserIdAsync(id);
            return texts;
        }

        // only admins
        public async Task<List<TextModel>> GetAllTexts()
        {
            var texts = await _textRepository.GetAllAsync();
            return _mapper.Map<List<TextModel>>(texts);
        }
    }
}
