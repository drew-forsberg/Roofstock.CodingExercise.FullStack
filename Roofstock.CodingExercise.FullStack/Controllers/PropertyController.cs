using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Roofstock.CodingExercise.FullStack.DataAccess.Entities;
using Roofstock.CodingExercise.FullStack.DataAccess.Repositories;
using Roofstock.CodingExercise.FullStack.Dtos;
using Roofstock.CodingExercise.FullStack.Mapping;
using Roofstock.CodingExercise.FullStack.Services;

namespace Roofstock.CodingExercise.FullStack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropertyController : ControllerBase
    {
        private readonly ILogger<PropertyController> _logger;
        private readonly IPropertyService _propertyService;
        private readonly IPropertyRepository _propertyRepository;
        private readonly IMapper _mapper;

        public PropertyController(ILogger<PropertyController> logger, IPropertyService propertyService, IPropertyRepository propertyRepository, IMapper mapper)
        {
            _logger = logger;
            _propertyService = propertyService;
            _propertyRepository = propertyRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<PropertyDto>> Get()
        {
            try
            {
                // Use the Property service to make the API call to get property data from Roofstock
                var properties = await _propertyService.GetAllProperties();

                // Convert the results to a simplified format for display purposes
                // The conversion is too complex for AutoMapper
                var displayProperties = properties.Select(property => property.ToDto());

                return displayProperties;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "API call to retrieve properties from Roofstock failed");
                throw;
            }
        }

        [HttpPost]
        public async Task Post(PropertyDto propertyDto)
        {
            if (propertyDto == null)
            {
                throw new ArgumentNullException(nameof(propertyDto));
            }

            try
            {
                // Convert the property DTO to the DB entity
                var propertyEntity = _mapper.Map<Property>(propertyDto);

                // Create or update the property, depending on whether it has already been saved by the user
                await _propertyRepository.CreateOrUpdate(propertyEntity);
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Property ID = {propertyDto.Id} could not be saved to the DB");
                throw;
            }
        }
    }
}
