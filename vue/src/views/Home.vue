<template>
<div class="flex-container2">
  <div class="home">
    <h1>Home</h1>
    <!-- <p> <em> If you can see this, you are authenticated </em></p> -->
    <p>Welcome, {{this.$store.state.user.username}}!</p>
   <preferences-table/>
   <br/>
   <div>

    
    <a href="http://localhost:8080/findrestaurants">
   <button>Find New Restaurants</button>
   </a>
   <button>Send An Invite</button>
    <p>Recommended Restaurants:</p>
    

</div>
<div class="copy">
&copy; 2022 DDMS Business Solutions
</div>
  </div>
  </div>
   
      
</template>

<script>
import PreferencesTable from "@/components/PreferencesTable.vue";
export default {
  name: "home",
  components:{
    PreferencesTable
  }
};
</script>

<style>
@import url('https://fonts.googleapis.com/css2?family=Lusitana&family=Play&display=swap');


.flex-container2{
  display: flex;
  justify-content: center;
  background-color: floralwhite;
  margin-left: auto;
  margin-right:auto;
  width: 75%;
  height: 100vh;
  
}
.home{
  
  text-align: center;
  background-color: floralwhite;
  font-family: 'Lusitana', serif;
}

#app > div.flex-container2 > div > div:nth-child(3) > table{
    margin-left: auto;
    margin-right: auto;
}

#app > div.flex-container2 > div > div.copy{
    position: fixed;
    bottom:5px;
    width: 100%;
    left:0px;
    height:25px; 
}


/* #app > div.flex-container2 > div > button:nth-child(5){
  border: solid;
  border-width: .25px;
  border-radius: 15px;
  border-color: lightgray;
  margin-right: 5px;
  padding-top: 5px;
  padding-left: 15px;
  padding-bottom: 5px;
  padding-right: 15px;
  width: 200px;
}
#app > div.flex-container2 > div > button:nth-child(6){
  border: solid;
  border-width: .25px;
  border-radius: 15px;
  border-color: lightgray;
  padding-top: 5px;
  padding-left: 15px;
  padding-bottom: 5px;
  padding-right: 15px;
  width: 200px;
}

#app > div.flex-container2 > div > button:nth-child(5):hover{
 
  background-color: darkgray;
}
#app > div.flex-container2 > div > button:nth-child(6):hover{

  background-color: darkgray;
} */


</style>