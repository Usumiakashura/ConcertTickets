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
            if (_dirs != null)
            {
                foreach (var item in _dirs)
                {
                    _modelList.Add(ConcertTypeDBToViewModel(item));
                }
            }
            return _modelList;
        }

        public ConcertTypeViewModel ConcertTypeDBToViewModel(ConcertType concertType)
        {
            return new ConcertTypeViewModel() { ConcertType = concertType };
        }



    }
}
