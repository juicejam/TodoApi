using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApi.Controllers
{
    //GetTodoItems和GetTodoItem 方法的返回类型是ActionResult<T>类型。
    //ASP.NET Core 自动将对象序列化为JSON，并将JSON写入响应消息的正文上。
    //在假设没有未经处理的异常的情况下，此返回类型的响应代码为200.未经处理的异常将转换为5xx错误。
    //ActionResult返回类型可以表示大范围的HTTP状态代码。


    [Route("api/[controller]")]
    [ApiController]//使用ApiController属性装饰类。此属性指示控制器响应Web Api请求
    public class TodoController : ControllerBase
    {
        //使用DI将数据库上下文(TodoContext)注入到控制器中。数据库上下文将在控制器的每个CRUD方法中使用
        private readonly TodoContext _context;



        public TodoController(TodoContext context)
        {
            _context = context;
            //如果数据库为空，则将名为Item1的项添加到数据库。此代码位于构造函数中，因此每次出现新HTTP请求时运行。
            //如果删除所有项，则构造函数会在下次调用API方法时再次创建Item1。因此删除可能看上去不起作用，不过实际上确实有效。
            if (!_context.TodoItems.Any())
            {
                _context.TodoItems.Add(new TodoItem {Name = "Item1"});
                _context.SaveChanges();
            }
        }
        
        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItem()
        {
            return await _context.TodoItems.ToListAsync();
        }
        
        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(long id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        // POST: api/Todo
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem item)
        {
            _context.TodoItems.Add(item);
            await _context.SaveChangesAsync();
            //如果成功，返回HTTP 201状态码。HTTP 201是在服务器上创建新资源的HTTP POST方法的标准响应。
            //引用GetTodoItem操作以创建Location标头的URI。
            //nameof关键字用于避免在CreatedAtAction调用中硬编码操作名称
            return CreatedAtAction(nameof(GetTodoItem), new {id = item.Id}, item);
        }

        // PUT: api/Todo/5
        //PutTodoItem与PostTodoItem类似，但是使用的是HTTP PUT。响应是204(无内容)。
        //根据HTTP规范，PUT请求需要客户端发送整个更新的实体，而不仅仅是更改。若要支持部分更新，请使用HTTP PATCH
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, TodoItem item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/Todo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(long id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todoItem);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
