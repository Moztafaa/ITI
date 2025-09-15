function showAddr(addrObj) {
  let currentDate = new Date();
  let formattedDate = `${currentDate.getDate()}/${
    currentDate.getMonth() + 1
  }/${currentDate.getFullYear()}`;
  return `${addrObj.buildingNum} ${addrObj.street}, ${addrObj.city} city registered in ${formattedDate}`;
}
const addrObj = {
  street: "abc st.",
  buildingNum: 15,
  city: "xyz",
};
console.log(showAddr(addrObj));
