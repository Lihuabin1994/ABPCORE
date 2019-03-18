using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Collections.Extensions;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.IdentityFramework;
using Abp.Linq.Extensions;
using Microsoft.AspNetCore.Identity;
using VueCore.Authorization;
using VueCore.Trades.Dto;

namespace VueCore.Trades
{
    [AbpAuthorize(PermissionNames.Pages_Trades)]
    public class TradeService : AsyncCrudAppService<Trade, TradeDto, int, PageTradeResultRequestDto, CreateTradeDto, TradeDto>, ITradeService
    {
        private readonly IRepository<Trade> _tradeRepository;
        public TradeService(
            IRepository<Trade,int>repository,
            IRepository<Trade>tradeRepository)
            :base(repository)
        {
            _tradeRepository = tradeRepository;
        }

        protected override async Task<Trade> GetEntityByIdAsync(int id)
        {
            var trade = await Repository.FirstOrDefaultAsync(x => x.Id == id);
            if(trade==null)
            {
                throw new EntityNotFoundException(typeof(Trade), id);
            }
            return trade;
        }

        protected override IQueryable<Trade> CreateFilteredQuery(PageTradeResultRequestDto input)
        {
            return Repository.GetAll()
                .WhereIf(!input.AccountNo.IsNullOrWhiteSpace(),x=>x.AccountNo.Contains(input.AccountNo))
                .WhereIf(!input.ProductCode.IsNullOrWhiteSpace(), x => x.ProductCode.Contains(input.ProductCode));
        }
         public override async Task<TradeDto>Create(CreateTradeDto input)
        {
            CheckCreatePermission();
            var trade = ObjectMapper.Map<Trade>(input);
           //await Repository.InsertAsync(trade);
           var result=await _tradeRepository.InsertAsync(trade);
            return ObjectMapper.Map<TradeDto>(result);
            
        }

        public override async Task<TradeDto> Update(TradeDto input)
        {
            CheckUpdatePermission();
            var trade = await _tradeRepository.GetAsync(input.Id);
            MapToEntity(input,trade);
            await _tradeRepository.UpdateAsync(trade);
            return await Get(input);
        }

        public override async Task Delete(EntityDto<int> input)
        {
            var trade = await _tradeRepository.GetAsync(input.Id);
            await _tradeRepository.DeleteAsync(trade);
        }
        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
      
    }
}
