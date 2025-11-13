<script lang="ts">
  import { chai } from "vitest";

    let sections = {1: "Chapters", 2: "Students", 3: "Chat"}
    let currentSection = $state(1)

</script>

{#snippet chapters()}
<ol>
    <li>1</li>
    <li>2</li>
    <li>3</li>
</ol>
{/snippet}

{#snippet students()}
<li>Me</li>
{/snippet}

{#snippet chat()}
<input type="text">
{/snippet}

<nav class="h-screen border border-black">
    <section class="bg-[#07b6a1] h-[20%] flex flex-col">
        <div class="section-items flex flex-row justify-around items-center list-none order-2 mt-auto">
            {#each Object.entries(sections) as [id, label]}
                <!-- <li class="{Number(id) === currentSection ? 'text-amber-300': 'text-amber-50'}" onclick={() => currentSection = Number(id)}>{label}</li> -->
            {/each}
        </div>
    </section>

    <section class="h-[80%]">
    {#if currentSection == Number(1)}
        {@render chapters()}
    {:else if currentSection == Number(2)}
        {@render students()}
    {:else}
        {@render chat()}
    {/if}
    </section>




</nav>


<style>
    
</style>