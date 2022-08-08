<template>
  <div class="home">
    <h1>Home</h1>
    <p> <em> If you can see this, you are authenticated </em></p>
    <p>welcome {{this.$store.state.user.username}}!</p>
   <preferences-table/>
    <button>setup matching sessions</button>
    <button>find new restaurants</button>
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

</sty
    PreferencesTablele>