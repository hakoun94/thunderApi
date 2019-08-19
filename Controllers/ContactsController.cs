﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThunderApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ThunderApi.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ThunderContext _context ;
        public ContactsController(ThunderContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
        {
            return await _context.Contacts.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContact(long id)
        {
            var contactItem = await _context.Contacts.FindAsync(id);
            if (contactItem == null)
            {
                return NotFound();
            }
            return contactItem;
        }

        [HttpPost]
        public async Task<ActionResult<Contact>> CreateContact(Contact item)
        {
            _context.Contacts.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetContact), new { id = item.Id }, item);
        }
    }
}
