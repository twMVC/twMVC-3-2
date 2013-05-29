jQuery.validator.addMethod("nois", function (value, element, param) {
  if (value == false) {
    return true;
  }
  if (value.indexOf(param) != -1) {
    return false;
  }
  else {
    return true;
  }
});
jQuery.validator.unobtrusive.adapters.addSingleVal("nois", "input");
