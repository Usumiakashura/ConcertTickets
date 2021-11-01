using BuissnesLayer;
using DataLayer.Entityes;
using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresentationLayer.Services
{
    public class ConcertTypeService
    {
        private DataManager _dataManager;
        public ConcertTypeService(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        public List<ConcertTypeViewModel> GetConcertTypesList()
        {
            var _dirs = _dataManager.ConcertTypess.GetAllConcertTypes();
            List<ConcertTypeViewModel> _modelList = new List<ConcertTypeViewModel>();
            foreach (var item in _dirs)
            {
                _modelList.Add(ConcertTypeDBToViewModelById(item.Id));
            }
            return _modelList;
        }

        public ConcertTypeViewModel ConcertTypeDBToViewModelById(int concertTypeId)
        {
            var _concertType = _dataManager.ConcertTypess.GetConcertTypeById(concertTypeId);

            return new ConcertTypeViewModel() { ConcertType = _concertType };
        }




    }
}
