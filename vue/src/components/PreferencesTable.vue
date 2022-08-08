<template>
  <div>
       <table name="preferences">
        <thead>preferences (will read from database)</thead>
        <tr>{{this.preferences.preferenceType}}</tr>
        </table>
  </div>
</template>

<script>
import PreferencesService from "@/services/PreferencesService.js"

export default {
    name: "preferences-table",
    data(){
        return{
            preferences: {
                preferenceId: 0,
                preferenceType: ""
            }
        }
    },
    created(){
        PreferencesService.getPreferencesByUserId(this.$store.state.user.userId).then((response) => {
      let preferencesData = response.data;
      this.preferences = preferencesData;
    });
    }
}
</script>

<style>

</style>