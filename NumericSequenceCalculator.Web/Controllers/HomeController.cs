using NumericSequenceCalculator.Lib.Core;
using NumericSequenceCalculator.Lib.Utilities;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace NumericSequenceCalculator.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult NumericSequencer(string sequenceNumber)
        {
            try
            {
                //Storing params to ViewBag to send them back for the view
                ViewBag.sequenceNumber = sequenceNumber;

                //If param is null or empty then return default view
                if (string.IsNullOrEmpty(sequenceNumber))
                {
                    return View();
                }

                //If params < 0 then show message
                if (int.Parse(sequenceNumber) < 0)
                {
                    ViewBag.Message = "Please enter whole number";
                    ViewBag.Results = "0";
                }
                else
                {
                    int sequenceNum = int.Parse(sequenceNumber);

                    NumericSequenceGen numericSequenceGen = new NumericSequenceGen();

                    ViewBag.OddNumbersequence = numericSequenceGen.GetOddNumbers(sequenceNum);
                    ViewBag.EvenNumbersequence = numericSequenceGen.GetEvenNumbers(sequenceNum);
                    ViewBag.AllNumbersequence = numericSequenceGen.GetAllNumbers(sequenceNum);
                    ViewBag.SpecialNumbersequence = numericSequenceGen.GetSpecialCases(sequenceNum);
                }
            }
            catch (Exception e)
            {
                Log4netWrapper.Error(e);

                ViewBag.Results = "0";
                ViewBag.Message = e.Message;
            }

            return View();
        }
    }
}