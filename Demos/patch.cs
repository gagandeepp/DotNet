using System;
namespace PatchDemo;

class SampleController : ControllerBase
{
    [HttpPatch]
    public IActionResult JsonPatchWithModelState([FromBody] JsonPatchDocument<Customer> patchDoc)
    {
        if (patchDoc != null)
        {
            var customer = CreateCustomer();

            patchDoc.ApplyTo(customer, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return new ObjectResult(customer);
        }
        else
        {
            return BadRequest(ModelState);
        }

    }
}

