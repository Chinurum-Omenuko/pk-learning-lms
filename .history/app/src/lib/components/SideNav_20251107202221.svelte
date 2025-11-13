<script lang="ts">
    let sections = {1: "Chapters", 2: "Students", 3: "Chat"}

</script>

<nav class="h-screen border border-black">
    <section class="bg-[#07b6a1] h-[20%] flex flex-col">
        <div class="section-items flex flex-row justify-around items-center list-none order-2 mt-auto">
            {#each sections as section}
                <li class="">Chapters</li>
            {/each}
            <li>Students</li>
            <li>Chat</li>
        </div>
    </section>


</nav>


<style>
    
</style>